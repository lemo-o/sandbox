namespace Selenium
{
    class Working
    {
        static void Main(string[] args)
        {
            BaseComponent baseComponent = new BaseComponent();
            Navigate navigate = new Navigate();
            navigate.Nav(Constants.URLs[0]);
        }
    }
}