import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShowProductSpeakerComponent } from './show-product-speaker.component';

describe('ShowProductSpeakerComponent', () => {
  let component: ShowProductSpeakerComponent;
  let fixture: ComponentFixture<ShowProductSpeakerComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShowProductSpeakerComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShowProductSpeakerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
