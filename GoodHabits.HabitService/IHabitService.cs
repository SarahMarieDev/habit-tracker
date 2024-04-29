using GoodHabits.Database.Entities;

namespace GoodHabits.HabitService;

public interface IHabitService
{
    Task<Habit> Create(string name, string description);
    Task<HabitService> GetById(int id);
    Task<IReadOnlyList<Habit>> GetAll();
}