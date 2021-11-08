﻿namespace Services.UseCases.Utils
{
    public interface IQueryFiltering<out TO, in TI>
    {
        TO Execute(TI dto);
    }
}