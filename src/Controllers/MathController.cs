using TestCoverage.Services;
using Microsoft.AspNetCore.Mvc;

namespace TestCoverage.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private readonly IMathService _mathService;
    public MathController(IMathService mathService)
    {
        _mathService = mathService;
    }
}