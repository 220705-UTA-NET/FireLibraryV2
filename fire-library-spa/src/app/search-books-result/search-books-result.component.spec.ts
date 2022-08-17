import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SearchBookResultComponent } from './search-book-result.component';

describe('SearchBookResultComponent', () => {
  let component: SearchBookResultComponent;
  let fixture: ComponentFixture<SearchBookResultComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SearchBookResultComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(SearchBookResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
