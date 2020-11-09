using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Web;
using System.Runtime.InteropServices;
using System.Web.Configuration;

namespace TriviaApp
{
    class TriviaResult
    {
        public string category;
        public string type;
        public string difficult;
        public string question;
        public string correct_answer;
        public List<string> incorrect_answers;
    }
    class Trivia
    {
        public int response_code;
        public List<TriviaResult> results;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string url = null;
            string s = null;

            HttpWebRequest request;
            HttpWebResponse response;
            StreamReader reader;

            url = "http://opentdb.com/api.php?amount=1";

            request = (HttpWebRequest)WebRequest.Create(url);
            response = (HttpWebResponse)request.GetResponse();
            reader = new StreamReader(response.GetResponseStream());
            s = reader.ReadToEnd();
            reader.Close();

            Trivia trivia = JsonConvert.DeserializeObject<Trivia>(s);

            trivia.results[0].question = HttpUtility.HtmlDecode(trivia.results[0].question);
            trivia.results[0].correct_answer = HttpUtility.HtmlDecode(trivia.results[0].correct_answer);
            /*
            for (int i = 0; i < trivia.results[0].incorrect_answers.Count; ++i)
            {
                trivia.results[0].incorrect_answers[i] = HttpUtility.HtmlDecode(trivia.results[0].question);
            }*/

            Console.WriteLine(trivia.results[0].question);

            Random rnd = new Random();
            int num;
            int resultsNum = trivia.results[0].incorrect_answers.Count + 1;
            int answer = 0;

            string[] check = new string[resultsNum];
            for (int i = 0; i < check.Length; ++i)
            {
                check[i] = null;
            }

            for (int i = 0; i < resultsNum; ++i)
            {

                bool success = false;

                do
                {
                    num = rnd.Next(0, resultsNum);

                    if (check[num] == null)
                    {

                        if (num == 0)
                        {
                            Console.WriteLine((i + 1) + ": " + trivia.results[0].correct_answer);
                            check[num] = "Right";
                            answer = i + 1;
                            success = true;
                        }
                        else
                        {
                            Console.WriteLine((i + 1) + ": " + trivia.results[0].incorrect_answers[num -1]);
                            check[num] = "Wrong";
                            success = true;
                        }
                    }
                } while (!success);
            }

            int get = 5;
            bool getCheck = false;
            do
            {
                try
                {
                    get = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please input valid integer.");
                    getCheck = false;
                }

                if (get <= resultsNum && get >= 1)
                {
                    getCheck = true;
                }


            } while (!getCheck);

            if (get == answer)
            {
                Console.WriteLine("Correct");
            } 
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}
