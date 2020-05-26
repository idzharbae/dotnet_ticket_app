namespace AuthApp.Internal.App {
    public class Auth {
        public string secretKey {get;}
        public UseCases uc {get;}
        public Repos repos {get;}
        public Auth() {
            secretKey = "dGhpcyBpcyBhIHZlcnkgc2VjcmV0IGFuZCBzZWN1cmUga2V5";
            repos = new Repos();
            uc = new UseCases(repos, secretKey);
        }
    }
}