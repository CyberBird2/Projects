import { Component, OnInit } from '@angular/core';

import * as StompJs from '@stomp/stompjs';
import * as SockJS from 'sockjs-client';

@Component({
  selector: 'app-websocket',
  templateUrl: './notifications.component.html',
  styleUrls: ['./notifications.component.css']
})
export class NotificationsComponent implements OnInit {

  public notifications: string[] = [];

  private client: StompJs.Client;
  ngOnInit(): void {

  }
  connectClicked() {
    if (!this.client || this.client.connected) {
      this.client = new StompJs.Client({
        webSocketFactory: () => new SockJS('http://localhost:8081/notifications'),
        debug: (msg: string) => console.log(msg)
      });

      this.client.onConnect = () => {

        this.client.subscribe('/user/notification/item', (response) => {
          const text: string = JSON.parse(response.body).text;
          console.log('Got ' + text);
          this.notifications.push(text);
        });

        console.info('connected!');
      };

      this.client.onStompError = (frame) => {
        console.error(frame.headers.message);
        console.error('Details:', frame.body);
      };

      this.client.activate();
    }
  }

  disconnectClicked() {
    if (this.client && this.client.connected) {
      this.client.deactivate();
      this.client = null;
      console.info('disconnected :-/');
    }
  }

  startClicked() {
    if (this.client && this.client.connected) {
      this.client.publish({destination: '/ToDoList/start'});
    }
  }

  stopClicked() {
    if (this.client && this.client.connected) {
      this.client.publish({destination: '/ToDoList/stop'});
    }
  }
}
