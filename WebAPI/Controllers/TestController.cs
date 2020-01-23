using Microsoft.AspNetCore.Mvc;
using SharedModelLibrary;
using System;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        [Route("getselectliststring")]
        public List<ListBindItem<string>> GetSelectListString()
        {
            List<ListBindItem<string>> list = new List<ListBindItem<string>>();
            list.Add(new ListBindItem<string>("Bread, Cereal, Rice, and Pasta", "grains"));
            list.Add(new ListBindItem<string>("Vegetables", "vegetables"));
            list.Add(new ListBindItem<string>("Fruit", "fruit"));
            return list;
        }

        [HttpGet]
        [Route("getselectlistint")]
        public List<ListBindItem<int?>> GetSelectListInt()
        {
            List<ListBindItem<int?>> list = new List<ListBindItem<int?>>();
            list.Add(new ListBindItem<int?>("Bread, Cereal, Rice, and Pasta", SelectionStringToInt("grains")));
            list.Add(new ListBindItem<int?>("Vegetables", SelectionStringToInt("vegetables")));
            list.Add(new ListBindItem<int?>("Fruit", SelectionStringToInt("fruit")));
            return list;
        }

        [HttpGet]
        [Route("getdummy/{textfield}/{textarea}/{select}/{radio}")]
        public DummyView GetDummy(string textField, string textArea, string select, string radio)
        {
            DummyView dummy = new DummyView();

            dummy.TextFieldValue = textField;
            dummy.TextAreaValue = textArea;
            dummy.DateTimeValue = DateTime.Now.AddHours(-1);
            dummy.SelectStringValue = select;
            dummy.SelectIntValue = SelectionStringToInt(select);
            dummy.RadioStringValue = radio;
            dummy.RadioIntValue = SelectionStringToInt(radio);
            dummy.CheckboxStringValues = new List<string>(new string[] { select, radio });
            dummy.CheckboxIntValues = new List<int?>(new int?[] { SelectionStringToInt(select), SelectionStringToInt(radio) });

            DummyItemView dummyItem;

            for (int i = 0; i < 5; i++)
            {
                dummyItem = new DummyItemView();
                dummyItem.ID = Guid.NewGuid();
                dummyItem.Name = "Dummy " + i;
                dummyItem.Quantity = i * 2;
                dummyItem.UnitCost = i * 10;
                dummy.DummyItems.Add(dummyItem);
            }

            return dummy;
        }

        private int SelectionStringToInt(string value)
        {
            switch (value)
            {
                case "grains": return 0;
                case "vegetables": return 1;
                case "fruit": return 2;
                default: return -1;
            }
        }
    }
}