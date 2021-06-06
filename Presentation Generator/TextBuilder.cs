using System;
using System.IO;

namespace Presentation_Generator {
    class TextBuilder {
        

        public TextBuilder(string HTML_RESULT_FILE, string TEXT_FILE) {

            FileStream fileCreator = File.Create(TEXT_FILE);
            fileCreator.Close();
        }
    }
}
