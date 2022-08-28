namespace CSharpCourse.AbstractClasses.Ex01
{
    public class Solution
    {
        public static void Run()
        {
            var t1 = new UpperCaseFileTransformer();
            t1.TransformFile(@"AbstractClasses\Ex01\sample1.txt");

            var t2 = new RemoveStarsFileTransformer();
            t2.TransformFile(@"AbstractClasses\Ex01\sample2.txt");

            var t3 = new ChangeSwedishLettersFileTransformer();
            t3.TransformFile(@"AbstractClasses\Ex01\sample3.txt");
        }
    }
}
