using System;
using System.Security.Cryptography;
using System.Text;

namespace WcApi.Cryptography
{
    // ReSharper disable once InconsistentNaming
    public class CRC32 : HashAlgorithm
    {
        public const UInt32 DefaultPolynomial = 0xedb88320;
        public const UInt32 DefaultSeed = 0xffffffff;


        private UInt32 _hash;
        private readonly UInt32 _seed;
        private readonly UInt32[] _table;

        public override int HashSize => 32;

        public CRC32()
        {
            _table = InitializeTable(DefaultPolynomial);
            _seed = DefaultSeed;
            Initialize();
        }

        public CRC32(UInt32 polynomial, UInt32 seed)
        {
            _table = InitializeTable(polynomial);
            _seed = seed;
            Initialize();
        }

        public static string Crc32OfString(string s)
        {
            CRC32 crc32 = new CRC32();
            var original = Encoding.Default.GetBytes(s);
            var encoded = crc32.ComputeHash(original);

            StringBuilder sbEncoded = new StringBuilder();
            foreach (var t in encoded)
                sbEncoded.Append(t.ToString("x2"));

            return sbEncoded.ToString();
        }

        public sealed override void Initialize()
        {
            _hash = _seed;
        }

        protected override void HashCore(byte[] buffer, int start, int length)
        {
            _hash = CalculateHash(_table, _hash, buffer, start, length);
        }

        protected override byte[] HashFinal()
        {
            byte[] hashBuffer = UInt32ToBigEndianBytes(_hash);
            HashValue = hashBuffer;

            return hashBuffer;
        }

        public static UInt32 Compute(UInt32 polynomial, UInt32 seed, byte[] buffer)
        {
            return CalculateHash(
                InitializeTable(polynomial),
                seed,
                buffer,
                0,
                buffer.Length);
        }

        private static UInt32[] InitializeTable(UInt32 polynomial)
        {
            UInt32[] createTable = new UInt32[256];

            for (int i = 0; i < 256; i++)
            {
                UInt32 entry = (UInt32)i;

                for (int j = 0; j < 8; j++)
                {
                    if ((entry & 1) == 1)
                        entry = (entry >> 1) ^ polynomial;
                    else
                        entry = entry >> 1;
                }

                createTable[i] = entry;
            }

            return createTable;
        }

        private static UInt32 CalculateHash(UInt32[] table, UInt32 seed, byte[] buffer, int start, int size)
        {
            UInt32 crc = seed;

            for (int i = start; i < size; i++)
            {
                unchecked
                {
                    crc = (crc >> 8) ^ table[buffer[i] ^ crc & 0xff];
                }
            }

            return ~crc;
        }

        private byte[] UInt32ToBigEndianBytes(UInt32 x)
        {
            return new[] {
                (byte)((x >> 24) & 0xff),
                (byte)((x >> 16) & 0xff),
                (byte)((x >> 8) & 0xff),
                (byte)(x & 0xff)
            };
        }

    }
}
