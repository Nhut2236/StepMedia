using AutoMapper;
using Exercise.Base.Response;
using Exercise.Exceptions;

namespace Exercise.Commons
{
    public class Merger : Mapper
    {
        public Merger(IConfigurationProvider configurationProvider) : base(configurationProvider)
        {
        }

        public Merger(IConfigurationProvider configurationProvider, Func<Type, object> serviceCtor) : base(
            configurationProvider, serviceCtor)
        {
        }


        public BaseResponse<TResult, TField> MergeData<TResult, TField, TModel>(
            BaseResponse<TResult, TField> destination, List<TModel> model) where TResult : class, new()
            where TModel : new()
            where TField : class
        {
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));

            if (model == null)
            {
                destination.AddException(new RecordNotFoundException(nameof(model)));
                return destination;
            }

            TResult tResult = Map<TResult>(model);
            destination.SetResult(tResult);
            destination.SetTotal(model.Count);

            return destination;
        }

        public BaseResponse<TResult, TField> MergeData<TResult, TField, TModel>(
            BaseResponse<TResult, TField> destination, TModel model) where TResult : class, new()
            where TModel : new()
            where TField : class
        {
            if (destination == null)
                throw new ArgumentNullException(nameof(destination));

            if (model == null)
            {
                destination.AddException(new RecordNotFoundException($"{typeof(TModel).Name} not found"));
                return destination;
            }

            TResult tResult = Map<TResult>(model);
            destination.SetResult(tResult);
            destination.SetTotal(1);

            return destination;
        }
    }
}