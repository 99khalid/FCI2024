global using Application.Features.Towns.Commands.CreateTown;
global using Application.Features.Towns.Commands.UpdateTown;
global using Application.Features.Towns.Commands.DeleteTown;
global using Application.Features.Towns.Queries.GetTownById;
global using Application.Features.Towns.Queries.GetAllTowns;
global using Domain.Models;
global using MediatR;
global using Microsoft.AspNetCore.Mvc;
global using System.Threading.Tasks;
global using System;
global using System.Collections.Generic;
global using Infrastructure.DbContexts;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.Extensions.Configuration;
global using Microsoft.Extensions.DependencyInjection;
global using Infrastructure.Repositories;
global using Infrastructure.IRepositories;
