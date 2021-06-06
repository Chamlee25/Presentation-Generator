using System;
using System.IO;

namespace Presentation_Generator {
    class TextBuilder {

        private readonly string[] starterTags = { "<p" };
        private readonly string tagEnd = ">";
        private readonly string[] endTags = { "</p>" };
        

        public TextBuilder(string HTML_RESULT_FILE, string TEXT_FILE) {

            FileStream fileCreator = File.Create(TEXT_FILE);
            fileCreator.Close();

            StreamReader reader = new StreamReader(HTML_RESULT_FILE);
            string line;

            StreamWriter writer = new StreamWriter(TEXT_FILE, true);

            
            while ((line = reader.ReadLine()) != null) {
                
               foreach(string starterTag in starterTags) {
                    if (line.Contains(starterTag)) {
                        Console.WriteLine(line);
                        foreach (string endTag in endTags) {
                            if (line.Contains(endTag)) {
                                string temp = line.Substring(line.IndexOf(starterTag), line.IndexOf(endTag));
                                Console.WriteLine(temp);



                            } 
                        }
                    }
                }
            }
        }
    }
}
