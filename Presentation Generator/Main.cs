using System;
using System.IO;
using HTML;

namespace Presentation_Generator {

    class MainClass{


        public static string SOURCE_FILE = "SOURCE.html";
        public static string HTML_RESULT_FILE = "RESULT.html";
        public static string TEXT_FILE = "TEXT.txt";

        static int Main(string[] args) {
            new HTML_DOWNLOADER(args[0], SOURCE_FILE);
            new HTMLFileBuilder(SOURCE_FILE, HTML_RESULT_FILE);
            File.Delete(SOURCE_FILE);
            new TextBuilder(HTML_RESULT_FILE, TEXT_FILE);
             
            return 0;
        }
    }
}
