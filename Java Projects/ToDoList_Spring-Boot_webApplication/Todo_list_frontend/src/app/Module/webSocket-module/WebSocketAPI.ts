
import {NotificationsComponent} from '../../websocket/notifications..component';
import * as SockJS from 'sockjs-client';
// @ts-ignore
import * as Stomp from 'stompjs';

export class WebSocketAPI {
  webSocketEndPoint = 'http://localhost:8081/ws';
  topic = '/topic/greetings';
  stompClient: any;
  appComponent: NotificationsComponent;
  constructor(websocketComponent: NotificationsComponent) {
    this.appComponent = websocketComponent;
  }
  _connect() {
    console.log('Initialize WebSocketAPI Connection');
    const ws = new SockJS(this.webSocketEndPoint);
    this.stompClient = Stomp.over(ws);
    // tslint:disable-next-line:variable-name
    const _this = this;
    _this.stompClient.connect({}, function(frame) {
      _this.stompClient.subscribe(_this.topic, function(sdkEvent) {
        _this.onMessageReceived(sdkEvent);
      });

    }, this.errorCallBack);
  }

  _disconnect() {
    if (this.stompClient !== null) {
      this.stompClient.disconnect();
    }
    console.log('Disconnected');
  }

  // on error, schedule a reconnection attempt
  errorCallBack(error) {
    console.log('errorCallBack -> ' + error);
    setTimeout(() => {
      this._connect();
    }, 5000);
  }
  _send(message) {
    console.log('calling logout api via web socket');
    this.stompClient.send('/app/hello', {}, JSON.stringify(message));
  }

  onMessageReceived(message) {
    console.log('Message Recieved from Server :: ' + message);
    this.appComponent.handleMessage(JSON.stringify(message.body));
  }
}
