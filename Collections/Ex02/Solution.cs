using ConsoleUtilities;

namespace CSharpCourse.Collections.Ex02
{
    public class Solution
    {
        static readonly ConsoleCompanion _cc = new();

        public static void ProductDictionary()
        {
            Dictionary<int, string> products = BuildProductDictionary();
            DisplayProductDictionary(products);
        }

        private static Dictionary<int, string> BuildProductDictionary()
        {
            var productDic = new Dictionary<int, string>();

            while (true)
            {
                string answer = _cc.AskForString("Enter product id and name:");
                answer = answer.Trim();

                if (answer == "")
                    return productDic;

                int productId = int.Parse(answer.Split(',')[0]);
                string productName = answer.Split(',')[1];

                if (productDic.ContainsKey(productId))
                    _cc.WriteLineRed($"The product list already contains the id {productId}");
                else
                    productDic.Add(productId, productName);
            }
        }

        private static void DisplayProductDictionary(Dictionary<int, string> products)
        {
            foreach (var product in products)
            {
                _cc.WriteLineDark($"Product id={product.Key} and name={product.Value}");
            }
        }
    }
}
