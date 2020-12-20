using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using TestingApp.Libs.Ranges;

namespace TestingApp.Forms
{
    public partial class SerializerForm : Form
    {
        public SerializerForm()
        {
            InitializeComponent();
        }

        public void CreateFile()
        {
            Range range = new Range { Inn = "7705558005", IndexFrom = 125993, DateInfo = "28.02.2019 12:18:04" };

            Segment segment1 = new Segment{ NumBeg = 25828, NumEnd = 25830, State = State.Free, NumMonth = 229 };
            Segment segment2 = new Segment{ NumBeg = 25832, NumEnd = 26292, State = State.Free, NumMonth = 229 };
            Segment segment3 = new Segment{ NumBeg = 26298, NumEnd = 26298, State = State.Free, NumMonth = 229 };
            Segment segment4 = new Segment{ NumBeg = 26300, NumEnd = 26300, State = State.Free, NumMonth = 229 };

            range.Segments.Add(segment1);
            range.Segments.Add(segment2);
            range.Segments.Add(segment3);
            range.Segments.Add(segment4);

            RangeSerializer.Save(range, $@"C:\test\{range.GetFileName()}");

            Range inteRange = new Range { Inn = "7735057951", IndexFrom = 125993, DateInfo = "07.08.2019 19:10:01" };
            Segment interSegment = new Segment { MailTypePref = "RO", NumBeg = 13192201, NumEnd = 13192256, State = State.Free };

            inteRange.Segments.Add(interSegment);
            RangeSerializer.Save(inteRange, $@"C:\test\{inteRange.GetFileName()}");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            CreateFile();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            Range range = RangeSerializer.Load(@"C:\test\007705558005_125993_20190228121804.xml");
            if (range != null)
            {
                richTextBox.AppendText($"{range.GetFileName()}\n");
                richTextBox.AppendText($"{range.Inn} | {range.Date.ToShortDateString()} | {range.DateInfo} | {range.IndexFrom} | {range.Crc} \n");
                foreach (Segment segment in range.Segments)
                {
                    richTextBox.AppendText($"{segment.NumBeg} - {segment.NumEnd} ({segment.Count}) - {segment.StateInfo}\n");
                }
            }

            richTextBox.AppendText("\n");

            Range interRange = RangeSerializer.Load(@"C:\test\007735057951_125993_20190807191001.xml");
            if (range != null)
            {
                richTextBox.AppendText($"{interRange.GetFileName()}\n");
                richTextBox.AppendText($"{interRange.Inn} | {interRange.Date.ToShortDateString()} | {interRange.DateInfo} | {interRange.IndexFrom} | {interRange.Crc} \n");
                foreach (Segment segment in interRange.Segments)
                {
                    richTextBox.AppendText($"{segment.MailTypePref}: {segment.NumBeg} - {segment.NumEnd} ({segment.Count}) - {segment.StateInfo}\n");
                }
            }

        }
    }
}
