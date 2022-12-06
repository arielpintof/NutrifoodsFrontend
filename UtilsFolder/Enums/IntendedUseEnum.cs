using System.Collections.Immutable;
using Ardalis.SmartEnum;

namespace NutrifoodsFrontend.UtilsFolder.Enums;

public class IntendedUseEnum : SmartEnum<IntendedUseEnum>
{
    public static readonly IntendedUseEnum None =
        new(nameof(None), (int) IntendedUse.None, IntendedUse.None, string.Empty);

    public static readonly IntendedUseEnum LoseWeight =
        new(nameof(LoseWeight), (int) IntendedUse.LoseWeight, IntendedUse.LoseWeight, "Perder peso");

    public static readonly IntendedUseEnum MaintainWeight =
        new(nameof(MaintainWeight), (int) IntendedUse.MaintainWeight, IntendedUse.MaintainWeight, "Mantener peso");

    public static readonly IntendedUseEnum GainWeight =
        new(nameof(GainWeight), (int) IntendedUse.GainWeight, IntendedUse.GainWeight, "Subir de peso");

    private static readonly IDictionary<IntendedUse, IntendedUseEnum> TokenDictionary =
        new Dictionary<IntendedUse, IntendedUseEnum>
        {
            {IntendedUse.None, None},
            {IntendedUse.LoseWeight, LoseWeight},
            {IntendedUse.MaintainWeight, MaintainWeight},
            {IntendedUse.GainWeight, GainWeight}
        };

    private static readonly IDictionary<string, IntendedUseEnum> ReadableNameDictionary = TokenDictionary
        .ToImmutableDictionary(e => e.Value.ReadableName, e => e.Value, StringComparer.InvariantCultureIgnoreCase);

    public static IReadOnlyCollection<IntendedUseEnum> Values { get; } =
        TokenDictionary.Values.OrderBy(e => e.Value).ToList();

    public static IReadOnlyCollection<IntendedUseEnum> NonNullValues { get; } =
        TokenDictionary.Values.OrderBy(e => e.Value).Skip(1).ToList();

    public IntendedUseEnum(string name, int value, IntendedUse token, string readableName) : base(name, value)
    {
        Token = token;
        ReadableName = readableName;
    }

    public IntendedUse Token { get; }
    public string ReadableName { get; }

    public static IntendedUseEnum? FromReadableName(string name) =>
        ReadableNameDictionary.ContainsKey(name) ? ReadableNameDictionary[name] : null;

    public static IntendedUseEnum FromToken(IntendedUse token) => TokenDictionary[token];
}

public enum IntendedUse
{
    None = 0,
    LoseWeight = 1,
    MaintainWeight = 2,
    GainWeight = 3
}