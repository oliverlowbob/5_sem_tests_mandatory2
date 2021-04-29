using PhoneCompany;
using PhoneCompany.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowProject.Specs.Steps
{
    [Binding]
    public sealed class OrderStepDefinition
    {
    
        private readonly ScenarioContext _scenarioContext;
        private readonly Item _item = new Item();
        private int _quantity;
        private string _model;

        public OrderStepDefinition(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the model ordered is an (.*)")]
        public void GivenModelIs(string model)
        {
            _model = model;
       
        }

        [Given("the quantity is (.*)")]
        public void GivenTheQuantityIs(int quantity)
        {
            _quantity = quantity;

        }

        [When("the order is made")]
        public void WhenTheOrderIsMade()
        {
            _item.Model = _model;
            _item.Quantity = _quantity;
    
        }

        [Then("an order containing model iPhone 8 and quantity 2")]
        public void ThenTheResultShouldBe()
        {
            Console.WriteLine($"Order is made with Model: " +
                $"{_item.Model} and Quantity: {_item.Quantity}");

        }
    }
}
