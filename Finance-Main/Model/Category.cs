
namespace Finance.Main {

    public enum Categories {
        TRANSPORT,
        PLAYTIME,
        FOOD,
        VACATION
    }
    public class Category {
        public Categories Type;

        public Category(Categories category) {
            Type = category;
        }
    }
}