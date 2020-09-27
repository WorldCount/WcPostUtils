using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace WcApi.Print
{
#if false

    // This version of the PageImageList stores images as byte arrays. It is a little
    // more complex and slower than a simple list, but doesn't consume GDI resources.
    // This is important when the list contains lots of images (Windows only supports
    // 10,000 simultaneous GDI objects!)
    class PageImageList
    {
        // ReSharper disable once FieldCanBeMadeReadOnly.Local
        List<byte[]> _list = new List<byte[]>();

        // ReSharper disable once UnusedMember.Global
        public void Clear()
        {
            _list.Clear();
        }

        // ReSharper disable once UnusedMember.Global
        public int Count => _list.Count;

        // ReSharper disable once UnusedMember.Global
        public void Add(Image img)
        {
            _list.Add(GetBytes(img));
            img.Dispose();
        }

        public Image this[int index]
        {
            get { return GetImage(_list[index]); }
            set { _list[index] = GetBytes(value); }
        }

        byte[] GetBytes(Image img)
        {
            Metafile mf = img as Metafile;
            var enhMetafileHandle = mf.GetHenhmetafile().ToInt32();
            var bufferSize = GetEnhMetaFileBits(enhMetafileHandle, 0, null);
            var buffer = new byte[bufferSize];
            GetEnhMetaFileBits(enhMetafileHandle, bufferSize, buffer);

            return buffer;
        }

        Image GetImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data);
            return Image.FromStream(ms);
        }

        [System.Runtime.InteropServices.DllImport("gdi32")]
        static extern int GetEnhMetaFileBits(int hemf, int cbBuffer, byte[] lpbBuffer);
    }

#else

    // This version of the PageImageList is a simple List<Image>. It is simple,
    // but caches one image (GDI object) per preview page.
    public class PageImageList : List<Image>
    {
    }

#endif
}
