import { TestBed } from '@angular/core/testing';

import { MyBooksService } from './app/services/my-books.service';

describe('MyBooksService', () => {
  let service: MyBooksService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(MyBooksService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
