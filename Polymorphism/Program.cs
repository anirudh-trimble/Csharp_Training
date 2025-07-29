namespace Polymorphism
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var overloadDemo = new MethodOverloadingDemo();
            overloadDemo.Show();

            var overrideDemo = new MethodOverridingDemo();
            overrideDemo.Show();

            var operatorDemo = new OperatorOverloadingDemo();
            operatorDemo.Show();

        }
    }
}