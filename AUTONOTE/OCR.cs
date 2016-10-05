using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tesseract;

namespace AUTONOTE
{
    static class OCR
    {

        static bool inited = false;

        public static void Init()
        {

            inited = true;
        }

        public static bool IsInited()
        {
            return inited;
        }


        public static string ImageToText(Bitmap bmp)
        {
            using (var engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default))
            {
                using (var page = engine.Process(bmp))
                {
                    var text = page.GetText();
                    Console.WriteLine("Mean confidence: {0}", page.GetMeanConfidence());

                    return text;
                }
            }
        }
    }
}
