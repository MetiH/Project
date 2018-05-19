using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeShop.Models
{
    public class MockCoffeeRepository : ICoffeeRepository
    {
        private List<Coffee> _coffee;

        public MockCoffeeRepository()
        {
            if (_coffee == null)
            {
                InitializeCoffees();
            }
        }

        private void InitializeCoffees()
        {
            _coffee = new List<Coffee>
                {
                    new Coffee {Id = 1, Name = "Latte Macchiato", Price = 3.95M, ShortDescription = "Foamed milk with shots of espresso!", LongDescription = "Our Latte Macchiato begins with steaming creamy whole milk to create a delicate, meringue-like foam. Then our barista marks the top with shots of delicious espresso to ensure a robust first sip. The result is a smooth and satisfying drink with an intensely bold finish.", ImageUrl = "https://www.gourmesso.fr/blog/wp-content/uploads/sites/2/2017/03/Coconut-latte-macchiato-sur-une-table-en-bois.jpg", IsCoffeeOfTheWeek = true, ImageThumbnailUrl = "https://www.gourmesso.fr/blog/wp-content/uploads/sites/2/2017/03/Coconut-latte-macchiato-sur-une-table-en-bois.jpg"},
                    new Coffee {Id = 2, Name = "CAFFE Americano", Price = 3.95M, ShortDescription = "Shots of espresso and hot water!", LongDescription = "The Americano celebrates the flavors of espresso. It's a simple drink yet it must still be made with care. Our baristas immediately pour two espresso shots, the second they are pulled, into your cup and then quickly pour hot water over the top to produce a light layer of crema. The result is a wonderfully nuanced cup, with the depth that only freshly ground espresso can boast.", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1_ztsteiqj8Z_RaKDwzETKDh_pgOkZ4XLQhpat6BfNl0Js0tA", IsCoffeeOfTheWeek = false, ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT1_ztsteiqj8Z_RaKDwzETKDh_pgOkZ4XLQhpat6BfNl0Js0tA"},
                    new Coffee {Id = 3, Name = "Cappuccino", Price = 3.95M, ShortDescription = "A shot of espresso with foamed milk.", LongDescription = "At the height of a barista's craft lies the Cappuccino. Trained to know when each drink has reached a specific weight, our baristas pass the test when the drink you hold in your hand is a perfect balance of light and airy foam and deeply delicious espresso. And of course, just say so if you prefer yours even lighter.", ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSv4UtGJ46SdIRc-wcLbj0bDtDTqBLtmvYNtZ3A80x-pTdCOqbc4A", IsCoffeeOfTheWeek = false, ImageThumbnailUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSv4UtGJ46SdIRc-wcLbj0bDtDTqBLtmvYNtZ3A80x-pTdCOqbc4A"},
                    new Coffee {Id = 4, Name = "Caffè Mocha", Price = 4.95M, LongDescription = "We combine our rich, full-bodied espresso with bittersweet mocha sauce and steamed milk, then top it off with sweetened whipped cream. The classic coffee drink to satisfy your sweet tooth.  drops.", ImageUrl = "https://static.independent.co.uk/s3fs-public/styles/article_small/public/thumbnails/image/2017/03/07/10/mocha.jpg", IsCoffeeOfTheWeek = false, ImageThumbnailUrl = "https://static.independent.co.uk/s3fs-public/styles/article_small/public/thumbnails/image/2017/03/07/10/mocha.jpg"}
                };
        }
        public IEnumerable<Coffee> GetAllCoffees()
        {

            return _coffee;
        }

        public Coffee GetCoffeeById(int coffeeId)
        {
            return _coffee.FirstOrDefault(p => p.Id == coffeeId);
        }
    }
}
