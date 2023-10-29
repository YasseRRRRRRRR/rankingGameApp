using Microsoft.AspNetCore.Mvc;
using rankingGameApp.Models;

namespace rankingGameApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private static readonly IEnumerable<ItemModel> Items = new[]
        {
            new ItemModel{Id = 1, Title ="uncharted 4", ImageId=1, Rank=0, ItemType=1},
            new ItemModel{Id = 2, Title ="outlast", ImageId=2, Rank=0, ItemType=1},
            new ItemModel{Id = 3, Title ="doom", ImageId=3, Rank=0, ItemType=1},
            new ItemModel{Id = 4, Title ="monster hunter", ImageId=4, Rank=0, ItemType=1},
            new ItemModel{Id = 5, Title ="valorant", ImageId=5, Rank=0, ItemType=1},
            new ItemModel{Id = 6, Title ="not for broadcast", ImageId=6, Rank=0, ItemType=1},
            new ItemModel{Id = 7, Title ="dead by daylight", ImageId=7, Rank=0, ItemType=1},
            new ItemModel{Id = 8, Title ="dark souls 3", ImageId=8, Rank=0, ItemType=1},
            new ItemModel{Id = 9, Title ="the witcher 3", ImageId=9, Rank=0, ItemType=1},
            new ItemModel{Id = 10, Title ="sea of thieves", ImageId=10, Rank=0, ItemType=1},
        };

        [HttpGet("{itemType:int}")]
        public ItemModel[] Get(int itemType)
        {
            ItemModel[] items = Items.Where(i => i.ItemType == itemType).ToArray();
            System.Threading.Thread.Sleep(2000);
            return items;
        }

    }

}
