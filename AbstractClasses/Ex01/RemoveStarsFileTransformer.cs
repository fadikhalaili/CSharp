namespace CSharpCourse.AbstractClasses.Ex01
{
    public class RemoveStarsFileTransformer : FileTransformer
    {
        protected override string Transform(string content)
        {
            return content.Replace("*", "");
        }
    }
}
