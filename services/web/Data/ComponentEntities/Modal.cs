namespace web.Data.ComponentEntities {
    public class ModalEntity {
        public string ModalDisplay = "none;";
        public string ModalClass = "";
        public bool ShowBackdrop = false;
        public string ModalTitle = "";
        public string ModalBody = "";
        public void Open(string title, string body) {
            ModalDisplay = "block;";
            ModalClass = "Show";
            ModalTitle = title;
            ModalBody = body;
            ShowBackdrop = true;
        }
        public void Close() {
            ModalDisplay = "none";
            ModalClass = "";
            ShowBackdrop = false;
        }
    }
}