namespace Composite.Example03
{
    public class Bundle : IComponent
    {
        private List<IComponent> _elements = new List<IComponent>();

        public void Add(IComponent element)
        {
            _elements.Add(element);
        }
        public void ShowPrice()
        {
            Console.WriteLine("Bundle content:");
            foreach (var element in _elements)
            {
                element.ShowPrice();
            }
        }
    }
}
