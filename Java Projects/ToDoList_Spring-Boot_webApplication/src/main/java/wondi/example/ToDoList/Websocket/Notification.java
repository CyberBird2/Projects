package wondi.example.ToDoList.Websocket;

public class Notification {
    public String content;

    public Notification() {
    }

    public Notification(String content) {
        this.content = content;
    }

    public String getContent() {
        return content;
    }
}
