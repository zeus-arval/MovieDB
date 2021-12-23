namespace Domain.Common.Aids
{
    /// <summary>
    /// Class for transferring the data between layers
    /// </summary>
    public static class Copier
    {
        public static TTo CopyMembers<TFrom, TTo>(TFrom from, TTo to)
        {
            if (from == null) return default;
            if (to == null) return default;
            foreach (var property in from.GetType().GetProperties())
            {
                var name = property.Name;
                var p = to?.GetType().GetProperty(name);
                if (p is null) continue;
                var v = property.GetValue(from);
                Safe.Run(() => p.SetValue(to, v));
            }
            return to;
        }
    }
}
