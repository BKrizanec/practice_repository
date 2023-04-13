using Microsoft.AspNetCore.Mvc;
using CrudExercise04.Models;
using CrudExercise04.Repository;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CrudExercise04.Controllers;

public class BeerController : Controller
{
    DemoData _demoData;
    public BeerController()
    {
        _demoData = new DemoData();
    }
    public IActionResult Index()
    {        
        List<Beer> allBeers = _demoData.GetBeers().OrderBy(x => x.Id).ToList();

        return View(allBeers);
    }

    public IActionResult Details(int id)
    {
        Beer findBeer = _demoData.GetBeerById(id);

        try
        {
            if(findBeer == null)
            {
                return RedirectToAction("Index");
            }

            return View(findBeer);
        }
        catch
        {
            return RedirectToAction("Index");
        }
        
    }

    // GET
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    // POST
    public IActionResult Create(Beer newBeer)
    {
        try
        {
            int lastId = _demoData.GetBeers().OrderBy(x => x.Id).Last().Id;

            newBeer.Id = lastId + 1;

            _demoData.CreateNewBeer(newBeer);

            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET
    public IActionResult Edit(int id)
    {
        Beer findBeer = _demoData.GetBeerById(id);

        try
        {
            if (findBeer == null)
            {
                return RedirectToAction("Index");
            }

            return View(findBeer);
        }
        catch
        {
            return RedirectToAction("Index");
        }
    }

    // POST
    [HttpPost]
    public IActionResult Edit(int id, Beer editBeer)
    {
        try
        {
            _demoData.UpdateBeer(editBeer);
            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET

    public IActionResult Delete(int id) 
    {
        Beer findBeer = _demoData.GetBeerById(id);

        try
        {
            if (findBeer == null)
            {
                return RedirectToAction("Index");
            }

            return View(findBeer);
        }
        catch
        {
            return RedirectToAction("Index");
        }
    }

    // POST
    [HttpPost]
    public IActionResult Delete(int id, Beer deleteBeer)
    {
        try
        {
            _demoData.DeleteBeer(deleteBeer);
            return RedirectToAction("Index");
        }
        catch
        {
            return View();
        }
    }

    // GET
    public IActionResult Search(string search)
    {  
        try
        {
            if(!string.IsNullOrEmpty(search))
            {
                List<Beer> beers = _demoData.GetBeers().Where(b => b.Name.ToLower().Contains(search.ToLower())
                                                                || b.Brewery.ToLower().Contains(search.ToLower())
                                                                || b.Country.ToLower().Contains(search.ToLower())
                                                                || b.Type.ToLower().Contains(search.ToLower())
                                                                || b.AlcoholPercentage.ToString().ToLower().Contains(search.ToLower())).ToList();                
                
                return View("Index", beers);
            }

            return RedirectToAction("Index");
        }
        catch
        {
            return RedirectToAction("Index");
        }
    }
}
