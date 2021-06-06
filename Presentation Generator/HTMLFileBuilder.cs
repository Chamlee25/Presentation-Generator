using System;
using System.IO;



enum HTML_TAGS {
   IN,
   OUT
}

namespace Presentation_Generator {
    class HTMLFileBuilder {



        readonly string[] HTML_Entry_Tags = { "<p", "<h1", "<h2", "<h3" };
        readonly string[] HTML_End_Tags =  { "</p", "</h1", "</h2",">"};
        readonly string[] HTML_Break_Tags = { "<a" };

        public HTMLFileBuilder(string SOURCE_FILE, string TEXT_FILE) {
            StreamReader reader = new StreamReader(SOURCE_FILE);
            string line;
            FileStream fileCreator = File.Create(TEXT_FILE);
            fileCreator.Close();
            StreamWriter Writer = new StreamWriter(TEXT_FILE, true);















            HTML_TAGS ActiveTag = HTML_TAGS.OUT;


            while ((line = reader.ReadLine()) != null) {
                if (ActiveTag == HTML_TAGS.OUT) {
                    foreach (string tag in HTML_Entry_Tags) {
                        if (line.Contains(tag)) {
                            ActiveTag = HTML_TAGS.IN;
                        }

                        if (tag == "<h2") {

                            foreach (string breakTag in HTML_Break_Tags) {
                                if (!line.Contains(breakTag)) {
                                    ActiveTag = HTML_TAGS.OUT;
                                }
                            }
                        }
                    }

                }



                if (ActiveTag == HTML_TAGS.IN) {
                    Console.WriteLine(line);
                    Writer.WriteLineAsync(line);
                }

                foreach(string endTag in HTML_End_Tags) {
                    if (line.Contains(endTag)) {
                        ActiveTag = HTML_TAGS.OUT;
                    }
                }
            }

            reader.Close();
            Writer.Close();
            
        }

    }
}
