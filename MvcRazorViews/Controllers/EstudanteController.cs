using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{

    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Ana Silva", "R. A, n1", true),
        new EstudanteViewModel(2, "Karina Santos", "R. A, n1", true),
        new EstudanteViewModel(3, "Carlos Campos", "R. A, n1", true)
        
        
    };

    public IActionResult index()
    {
        return View();
    }

        public IActionResult show(int id)
    {
        //var estudante = new EstudanteViewModel(5, "Red Wacky League Antlez Broke the Stereo Neon Tide Bring Back Honesty Coalition Feedback Hand of Aces Keep Going Captain Let’s Pretend Lost State of Dance Paper Taxis Lunar Road Up Down Strange All and I Neon Sheep Eve Hornby Faye Bradley AJ Wilde Michael Rice Dion Watts Matthew Appleyard John Ashurst Lauren Swales Zoe Angus Jaspreet Singh Emma Matthews Nicola Brown Leanne Pickering Victoria Davies Rachel Burnside Gil Parker Freya Watson Alisha Watts James Pearson Jacob Sotheran Darley Beth Lowery Jasmine Hewitt Chloe Gibson Molly Farquhar Lewis Murphy Abbie Coulson Nick Davies Harvey Parker Kyran Williamson Michael Anderson Bethany Murray Sophie Hamilton Amy Wilkins Emma Simpson Liam Wales Jacob Bartram Alex Hooks Rebecca Miller Caitlin Miller Sean McCloskey Dominic Parker Abbey Sharpe Elena Larkin Rebecca Simpson Nick Dixon Abbie Farrelly Liam Grieves Casey Smith Liam Downing Ben Wignall Elizabeth Hann Danielle Walker Lauren Glen James Johnson Ben Ervine Kate Burton James Hudson Daniel Mayes Matthew Kitching Josh Bennett Evolution Dreams.", "Rua l, n. 11", true);

        return View(estudantes[id - 1]);
    }
}