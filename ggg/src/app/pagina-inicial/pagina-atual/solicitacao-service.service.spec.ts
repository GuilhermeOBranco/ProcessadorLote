import { TestBed } from '@angular/core/testing';

import { SolicitacaoServiceService } from './solicitacao-service.service';

describe('SolicitacaoServiceService', () => {
  let service: SolicitacaoServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SolicitacaoServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
