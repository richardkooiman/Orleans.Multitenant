﻿namespace Orleans4Multitenant.Services;

static class Errors
{
    internal static Result.Error UserNotFound(Guid id) => new(ErrorCode.UserNotFound, $"User {id} not found");
    internal static Result.Error IdIsNotEmpty(Guid id) => new(ErrorCode.IdIsNotEmpty, $"{id} is not the empty guid");
}
