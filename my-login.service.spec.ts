import { TestBed } from '@angular/core/testing';

import { MyLoginService } from './my-login.service';

describe('MyLoginService', () => {
  let service: MyLoginService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyLoginService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
