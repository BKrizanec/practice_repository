using CrudExercise04.Models;

namespace CrudExercise04.Repository;

public class DemoData
{
    private static List<Beer> _beerList;

    public DemoData() 
    {
        if (_beerList == null)
        {
            _beerList = new List<Beer>();
            BeerData();
        }
    }

    public List<Beer> GetBeers()
    {
        return _beerList;
    }

    public Beer GetBeerById(int id)
    {
        return _beerList.FirstOrDefault(x => x.Id == id);
    }

    public void CreateNewBeer(Beer newBeer)
    {
        _beerList.Add(newBeer);
    }    
    public void UpdateBeer(Beer editBeer)
    {
        Beer findBeer = _beerList.FirstOrDefault(x => x.Id == editBeer.Id);

        if (findBeer != null) 
        {
            _beerList.Remove(findBeer);
            _beerList.Add(editBeer);
        }
    }

    public void DeleteBeer(Beer deleteBeer) 
    {
        Beer findBeer = _beerList.FirstOrDefault(x => x.Id == deleteBeer.Id);

        if (findBeer != null)
        {
            _beerList.Remove(findBeer);
        }
    }    


    private void BeerData()
    {
        _beerList = new List<Beer>()
        {
            new Beer { Id = 1001, Name = "Heineken", Type = "Lager", AlcoholPercentage = 5, Brewery = "Heineken International", Country = "Netherlands" },
            new Beer { Id = 1002, Name = "Guinness", Type = "Stout", AlcoholPercentage = 4.2, Brewery = "Guinness & Co.", Country = "Ireland" },
            new Beer { Id = 1003, Name = "Corona", Type = "Lager", AlcoholPercentage = 4.5, Brewery = "Grupo Modelo", Country = "Mexico" },
            new Beer { Id = 1004, Name = "Budweiser", Type = "Lager", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "United States" },
            new Beer { Id = 1005, Name = "Stella Artois", Type = "Pilsner", AlcoholPercentage = 5, Brewery = "Anheuser-Busch InBev", Country = "Belgium" },
            new Beer { Id = 1006, Name = "Sapporo", Type = "Lager", AlcoholPercentage = 5, Brewery = "Sapporo Breweries Ltd.", Country = "Japan" },
            new Beer { Id = 1007, Name = "Peroni", Type = "Lager", AlcoholPercentage = 5.1, Brewery = "Peroni Brewery", Country = "Italy" },
            new Beer { Id = 1008, Name = "Asahi", Type = "Lager", AlcoholPercentage = 5, Brewery = "Asahi Breweries Ltd.", Country = "Japan" },
            new Beer { Id = 1009, Name = "Hoegaarden", Type = "Witbier", AlcoholPercentage = 4.9, Brewery = "InBev Belgium", Country = "Belgium" },
            new Beer { Id = 1020, Name = "Tsingtao", Type = "Lager", AlcoholPercentage = 4.7, Brewery = "Tsingtao Brewery Co. Ltd.", Country = "China" }
        };
    }
}
