namespace Exercise02 {
    
    public static class YardConverter {
        // 定数
        private const double ratio = 0.9144;

        public static double YardToMeter(int yard) {
            return yard * ratio;
        }
            
        public static double MeterToYard(int meter) {
            return meter / ratio;  
        }
    }
}
