using LandmarkApi.Application.DTOs;
using LandmarkApi.Application.Interfaces;
using LandmarkApi.Domain.Interfaces;

namespace LandmarkApi.Application.Services;

public class StateService : IStateService
{
    private readonly IStateRepository _repository;

    public StateService(IStateRepository repository)
    {
        _repository = repository;
    }

    public async Task<StateDto?> GetByIdAsync(int id)
    {
        var state = await _repository.GetByIdAsync(id);
        return state == null ? null : MapToDto(state);
    }

    public async Task<IEnumerable<StateDto>> GetAllAsync()
    {
        var states = await _repository.GetAllAsync();
        return states.Select(MapToDto);
    }

    private static StateDto MapToDto(Domain.Entities.State state)
    {
        return new StateDto
        {
            Id = state.Id,
            Acronym = state.Acronym,
            Name = state.Name,
            IbgeCode = state.IbgeCode
        };
    }
}
