namespace Laboratorna_5_4
{
    public class MyFactory<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }
}