f = $(firstword $(MAKECMDGOALS))

$(f): $(f).exe
	@mono $(f).exe
	@rm -f $(f).exe

$(f).exe: $(f).cs
	@mcs $(f).cs
