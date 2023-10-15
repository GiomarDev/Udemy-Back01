﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace back_end.Utilidades
{
    public class TypeBinder<T> : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var nombrePropiedad = bindingContext.ModelName;
            var valor = bindingContext.ValueProvider.GetValue(nombrePropiedad);

            if(valor == ValueProviderResult.None) { 
                return Task.CompletedTask;
            }

            try
            {
                var valorDeserealizado = JsonConvert.DeserializeObject<T>(valor.FirstValue);
                bindingContext.Result = ModelBindingResult.Success(valorDeserealizado);
            }
            catch (System.Exception)
            {
                bindingContext.ModelState.TryAddModelError(nombrePropiedad, "El valor dado no es del tipo adecuado");
                throw;
            }

            return Task.CompletedTask;
        }
    }
}
