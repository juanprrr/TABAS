import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BaggageToFlightComponent } from './baggage-to-flight.component';

describe('BaggageToFlightComponent', () => {
  let component: BaggageToFlightComponent;
  let fixture: ComponentFixture<BaggageToFlightComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BaggageToFlightComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BaggageToFlightComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
