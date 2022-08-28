namespace CSharpCourse.AbstractClasses.Ex01
{
    public class UpperCaseFileTransformer : FileTransformer
    {
        protected override string Transform(string content)
        {
            return content.ToUpper();
        }
    }
}
