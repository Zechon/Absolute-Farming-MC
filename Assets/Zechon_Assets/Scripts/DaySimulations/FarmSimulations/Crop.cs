public class Crop
{
    public float growthProgress = 0f;
    public float lightLevel = 15f; // adjustable per block
    public bool hydrated = true;

    public void ApplyRandomTick()
    {
        if (lightLevel < 9 || !hydrated)
            return;

        // base growth chance (roughly modeled after MC's crop growth rate)
        float chance = 1f / 25f; //once every 25 random ticks

        // modifier: crops next to each other slow growth a bit
        chance *= 0.9f; // simplified for now

        if (Random.value < chance)
        {
            growthProgress += 1f / 7f; // 7 stages of growth
            if (growthProgress > 1f) growthProgress = 1f;
        }
    }
}
