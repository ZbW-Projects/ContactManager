using ContactManager.Application.Abstractions.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ContactManager.Application.Abstractions.UseCases
{
    public interface IContactQueries
    {
        Task<IReadOnlyList<ContactListItemDto>> GetContactsAsync(ContactFilterDto filter);
        Task<IReadOnlyList<ContactListItemDto>> GetDeactivatedAsync();
        Task<ContactDetailsDto> GetByIdAsync(int id);
    }

    public interface IContactCommands
    {
        // Contact
        Task<ResultDtoT<int>> CreateContactAsync(ContactDetailsDto dto);

        Task<ResultDto> UpdateContactAsync(int id, ContactDetailsDto dto);
        Task<ResultDto> DeactivateAsync(int id);

        // Protocol
        Task<ResultDto> AddNoteAsync(int id, ProtocolDto dto);

    }
}
