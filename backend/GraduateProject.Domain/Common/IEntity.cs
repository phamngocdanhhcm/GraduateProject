﻿namespace GraduateProject.Domain.Common;

public interface IEntity<TKey>
{
    TKey Id { get; set; }
}