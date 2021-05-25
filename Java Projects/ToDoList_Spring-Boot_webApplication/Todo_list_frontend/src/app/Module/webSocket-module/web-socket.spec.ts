import { WebSocketAPI } from './WebSocketAPI';

describe('WebSocket', () => {
  it('should create an instance', () => {
    expect(new WebSocketAPI()).toBeTruthy();
  });
});
