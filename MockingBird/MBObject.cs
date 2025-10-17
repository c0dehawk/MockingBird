using System.Dynamic;

namespace MockingBird
{
    public class MBObject
    {
        public MBObject()
        {           
            Properties = new List<IMBProperty>();
        }     
      
        public List<IMBProperty> Properties { get; private set; }

        public void AddProperty(IMBProperty property)
        {
            Properties.Add(property);
        }

        public List<ExpandoObject> Mock(int count)
        {
            return MBDataFactory.GetData(this, count);
        }
    }
}
