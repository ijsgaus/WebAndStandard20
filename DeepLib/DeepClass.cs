namespace DeepLib
{
    public class DeepClass
    {
        public static string DeepValue => typeof(DeepClass).GetProperty(nameof(DeepValue)).Name;
    }
}