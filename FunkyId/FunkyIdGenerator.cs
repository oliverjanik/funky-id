using System.Security.Cryptography;

namespace OJ.FunkyId;

public static class FunkyIdGenerator
{
    private static readonly string[] Adjectives =
    {
        "boingy", "boppy", "bouncy", "bubbly", "cheeky", "drifty", "fluffy", "funky", "giddy",
        "goopy", "gritty", "jazzy", "jolly", "jumpy", "kooky", "lively", "loopy", "merry", "peppy",
        "perky", "poppy", "quirky", "snappy", "snazzy", "sparkly", "spicy", "spiffy", "spongy",
        "springy", "sprightly", "squishy", "twirly", "twisty", "wiggly", "whippy", "whizzy",
        "wobbly", "wonky", "zany", "zappy", "zesty", "zingy", "zippy"
    };

    private static readonly string[] Nouns =
    {
        "alpaca", "apple", "apricot", "avocado", "axolotl", "badger", "bandicoot", "bat", "beaver", "beetle", "bilby", "bison",
        "blueberry", "bobcat", "capybara", "cherry", "chicken", "chipmunk", "coconut", "corgi", "cow", "crow", "date", "deer",
        "dingo", "donkey", "dragonfruit", "durian", "echidna", "elk", "emu", "ferret", "fig", "flamingo", "frog", "gecko",
        "giraffe", "goose", "gorilla", "grape", "grapefruit", "guava", "hamster", "hedgehog", "hippo", "horse", "ibis", "iguana",
        "jackfruit", "jaguar", "kangaroo", "kiwi", "koala", "kumquat", "lemon", "lemur", "lime", "llama", "lychee", "lynx",
        "lyrebird", "mango", "meerkat", "melon", "mongoose", "moose", "mule", "narwhal", "nectarine", "newt", "numbat", "ocelot",
        "octopus", "orange", "ostrich", "otter", "owl", "panda", "pangolin", "papaya", "parrot", "peach", "peacock", "pear",
        "penguin", "pika", "pineapple", "platypus", "plum", "pony", "possum", "puffin", "puma", "quokka", "rabbit", "raccoon",
        "raspberry", "rhino", "seal", "skunk", "sloth", "snail", "squid", "squirrel", "starfruit", "stoat", "strawberry", "tangerine",
        "tapir", "toucan", "turtle", "viper", "vole", "wallaby", "walrus", "watermelon", "weasel", "whale", "wolverine", "wombat",
        "wren", "yak", "zebra"
    };

    private const string TagCharacters = "abcdefghijklmnopqrstuvwxyz0123456789";

    public static string Generate(int randomTagLength = 4)
    {
        if (randomTagLength <= 0)
            throw new ArgumentOutOfRangeException(nameof(randomTagLength), "Random tag length must be positive.");

        var adjective = Adjectives[RandomNumberGenerator.GetInt32(Adjectives.Length)];
        var noun = Nouns[RandomNumberGenerator.GetInt32(Nouns.Length)];
        var tag = BuildRandomTag(randomTagLength);

        return $"{adjective}_{noun}_{tag}";
    }

    private static string BuildRandomTag(int length)
    {
        var tag = new char[length];

        for (var i = 0; i < length; i++)
            tag[i] = TagCharacters[RandomNumberGenerator.GetInt32(TagCharacters.Length)];

        return new string(tag);
    }
}
