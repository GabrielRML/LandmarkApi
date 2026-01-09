using LandmarkApi.Application.DTOs;
using LandmarkApi.Application.Interfaces;
using LandmarkApi.Domain.Common;
using LandmarkApi.Domain.Entities;
using LandmarkApi.Domain.Interfaces;

namespace LandmarkApi.Application.Services;

public class TouristPointService : ITouristPointService
{
    private readonly ITouristPointRepository _repository;

    public TouristPointService(ITouristPointRepository repository)
    {
        _repository = repository;
    }

    public async Task<TouristPointDto?> GetByIdAsync(Guid id)
    {
        var touristPoint = await _repository.GetByIdAsync(id);
        return touristPoint == null ? null : MapToDto(touristPoint);
    }

    public async Task<IEnumerable<TouristPointDto>> GetAllAsync()
    {
        var touristPoints = await _repository.GetAllAsync();
        return touristPoints.Select(MapToDto);
    }

    public async Task<PagedResultDto<TouristPointDto>> GetPagedAsync(int pageNumber, int pageSize, string? name = null, string orderByCreatedAt = "desc")
    {
        var pagedResult = await _repository.GetPagedAsync(pageNumber, pageSize, name, orderByCreatedAt);
        
        return new PagedResultDto<TouristPointDto>
        {
            Items = pagedResult.Items.Select(MapToDto),
            TotalCount = pagedResult.TotalCount,
            PageNumber = pagedResult.PageNumber,
            PageSize = pagedResult.PageSize
        };
    }

    public async Task<TouristPointDto> CreateAsync(CreateTouristPointDto createDto)
    {
        var touristPoint = new TouristPoint
        {
            Id = Guid.NewGuid(),
            Name = createDto.Name,
            Description = createDto.Description,
            Location = createDto.Location,
            IbgeCode = createDto.IbgeCode,
            CityName = createDto.CityName,
            StateName = createDto.StateName,
            StateAcronym = createDto.StateAcronym
        };

        await _repository.AddAsync(touristPoint);
        return MapToDto(touristPoint);
    }

    public async Task<TouristPointDto?> UpdateAsync(Guid id, UpdateTouristPointDto updateDto)
    {
        var touristPoint = await _repository.GetByIdAsync(id);
        
        if (touristPoint == null)
            return null;

        touristPoint.Name = updateDto.Name;
        touristPoint.Description = updateDto.Description;
        touristPoint.Location = updateDto.Location;
        touristPoint.IbgeCode = updateDto.IbgeCode;
        touristPoint.CityName = updateDto.CityName;
        touristPoint.StateName = updateDto.StateName;
        touristPoint.StateAcronym = updateDto.StateAcronym;

        await _repository.UpdateAsync(touristPoint);
        return MapToDto(touristPoint);
    }

    public async Task<bool> DeleteAsync(Guid id)
    {
        var touristPoint = await _repository.GetByIdAsync(id);
        
        if (touristPoint == null)
            return false;

        await _repository.DeleteAsync(touristPoint);
        return true;
    }

    private static TouristPointDto MapToDto(TouristPoint touristPoint)
    {
        return new TouristPointDto
        {
            Id = touristPoint.Id,
            Name = touristPoint.Name,
            Description = touristPoint.Description,
            Location = touristPoint.Location,
            IbgeCode = touristPoint.IbgeCode,
            CityName = touristPoint.CityName,
            StateName = touristPoint.StateName,
            StateAcronym = touristPoint.StateAcronym,
            CreatedAt = touristPoint.CreatedAt
        };
    }
}
