using AutoMapper;
using GoodHabits.HabitService.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace GoodHabits.HabitService.Controllers;
[ApiController]
[Route("api/[controller]")]
public class HabitsController : ControllerBase
{
    private readonly ILogger<HabitsController> _logger;    
    private readonly IHabitService _habitService;
    private readonly IMapper _mapper;

    public HabitsController(
        ILogger<HabitsController> logger,
        IHabitService goodHabitsService,
        IMapper mapper
        )
    {
        _logger = logger;
        _habitService = goodHabitsService;
        _mapper = mapper;
    }
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(int id) => Ok(await _habitService.GetById(id));
    [HttpGet]
    public async Task<IActionResult> GetAsync() => Ok(await _habitService.GetAll());
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateHabitDto request) => Ok(await _habitService.Create(request.Name, request.Description));
}