using System.Linq.Expressions;

namespace G_Net_40_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Excersice 1
            //List<int> grades = [85, 92, 78, 95, 88, 70, 100, 65];
            //Console.WriteLine(string.Join(", ", grades));
            //Console.WriteLine($"Count {grades.Count}");
            //Console.WriteLine($"first : {grades[0]}");
            //Console.WriteLine($"last : {grades[^1]}");
            //grades.Sort();

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}
            //Console.WriteLine($"first grade above 90 : {grades.Find(x => x > 90)}");
            //var failingGrades = grades.FindAll(x => x < 75);

            //Console.WriteLine("Failing grades:");
            //foreach (var g in failingGrades)
            //{
            //    Console.WriteLine(g);
            //}
            //Console.WriteLine($"Remove all failing grades (below 75) {grades.RemoveAll(x => x < 75)}");
            //Console.WriteLine($"Check if any grade equals 100 {grades.Exists(x => x == 100)}");
            //List<string> Strings = new List<string>();
            //foreach (int grade in grades)
            //{
            //    Strings.Add("Grade: " + grade);
            //}

            //foreach (string g in Strings)
            //{
            //    Console.WriteLine(g);
            //}
            #endregion
            #region Excersice 2
            // SortedList<int, string> scores = new()
            // { [500] = "Ahmed", [200] = "Sara", [800] = "Ali", [350] = "Mona" };
            // foreach (var entry in scores)
            // {
            //     Console.WriteLine($"{entry.Value} : {entry.Key}");
            // }
            // Console.WriteLine($"first index  = {scores.Keys[0]}");
            // Console.WriteLine($"first value  = {scores.Values[0]}");
            //bool check = scores.ContainsKey( 500 );
            // scores.Remove(200);
            // foreach (var entry in scores)
            // {
            //     Console.WriteLine($"{entry.Value} : {entry.Key}");
            // }
            #endregion
            #region Excersice 3
            //Dictionary<string, string> phonenumbers = new()
            //{ ["pola"] = "01293843483", ["sara"] = "011193736332", ["mohmed"] = "012838922732", ["bishoy"] = "01223913837" };
            //phonenumbers["omar"] = "010999318888";
            //if (!phonenumbers.ContainsKey("omar"))
            //{
            //    phonenumbers.Add("omar", "010931135588");
            //}
            //phonenumbers.TryAdd("omar", "010931135588");
            //if (phonenumbers.TryGetValue("Omar", out string phone))
            //{
            //    Console.WriteLine(phone);
            //}
            //else
            //{
            //    Console.WriteLine("contact not found");
            //}
            //string phoneNumber = phonenumbers.GetValueOrDefault("Omar", "Not Found");
            //Console.WriteLine(phoneNumber);
            //Console.WriteLine(string.Join(", ", phonenumbers.Values));

            #endregion
        }
    }
}
