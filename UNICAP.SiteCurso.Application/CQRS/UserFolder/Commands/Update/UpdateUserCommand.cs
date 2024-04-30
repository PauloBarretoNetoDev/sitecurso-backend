﻿using MediatR;
using UNICAP.SiteCurso.Application.CQRS.BaseFolder;
using UNICAP.SiteCurso.Application.DTOs.GenericsFolder;
using UNICAP.SiteCurso.Domain.Enum;

namespace UNICAP.SiteCurso.Application.CQRS.UserFolder.Commands.Update
{
    public class UpdateUserCommand : UpdateBaseCommand, IRequest<Response>
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public Role Role { get; set; }
    }
}
