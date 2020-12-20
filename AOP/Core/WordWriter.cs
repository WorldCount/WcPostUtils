using System;
using System.Collections.Generic;
using System.IO;
using AOP.Core.Models;
using AOP.Core.Models.DB;
using NLog;
using NPOI.XWPF.UserModel;

namespace AOP.Core
{
    public static class WordWriter
    {
        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public static bool Write(string path, List<Rpo> rpos, string templatePath, string categoryName = "ПРОСТАЯ")
        {
            try
            {
                XWPFDocument document;

                using (FileStream fileStream = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
                {
                    document = new XWPFDocument(fileStream);
                }

                for (int i = 0; i < rpos.Count; i++)
                {
                    Replace replace = new Replace(rpos[i], categoryName);

                    if (i == 0)
                    {
                        foreach (XWPFTable table in document.Tables)
                        {
                            ReplaceTableValue(table, replace);
                        }

                        continue;
                    }

                    XWPFDocument template;
                    using (FileStream fileStream = new FileStream(templatePath, FileMode.Open, FileAccess.Read))
                    {
                        template = new XWPFDocument(fileStream);
                    }

                    CopyDocument(template, document, replace);

                    using (FileStream fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
                    {
                        document.Write(fileStream);
                    }
                }

                return true;
            }
            catch (Exception e)
            {
                Logger.Error(e.Message);
                return false;
            }
        }

        private static void CopyDocument(XWPFDocument template, XWPFDocument document, Replace replace)
        {
            foreach (var bodyElement in template.BodyElements)
            {
                BodyElementType elementType = bodyElement.ElementType;
                if (elementType == BodyElementType.PARAGRAPH)
                {
                    XWPFParagraph pr = (XWPFParagraph)bodyElement;
                    document.CreateParagraph();
                    int pos = document.Paragraphs.Count - 1;
                    document.SetParagraph(pr, pos);
                }
                else if (elementType == BodyElementType.TABLE)
                {
                    XWPFTable table = (XWPFTable)bodyElement;

                    // Replace
                    ReplaceTableValue(table, replace);

                    document.CreateTable();
                    int pos = document.Tables.Count - 1;
                    document.SetTable(pos, table);
                }
            }
        }

        private static void ReplaceTableValue(XWPFTable table, Replace replace)
        {
            foreach (XWPFTableRow row in table.Rows)
            foreach (XWPFTableCell cell in row.GetTableCells())
            foreach (XWPFParagraph p in cell.Paragraphs)
            foreach (XWPFRun r in p.Runs)
            {
                string text = r.GetText(0);
                if (text != null)
                {
                    foreach (string key in replace.Keys)
                    {
                        if (text.Contains(key))
                        {
                            text = text.Replace(key, replace.Data[key]);
                            r.SetText(text, 0);
                        }
                    }
                }
            }
        }
    }
}
