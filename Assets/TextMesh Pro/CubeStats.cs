namespace TextMesh_Pro
{
    public class CubeStats
    {
        public CubeStats(float speed,float destroyDist)
        {
            this.speed = speed;
            this.destroyDist = destroyDist;
        }
        public CubeStats(CubeStats stats)
        {
            this.speed = stats.speed;
            this.destroyDist = stats.destroyDist;
        }
        public float speed;
        public float destroyDist;
    }
}