using System;
using System.Linq;
using System.Collections.Generic;

namespace FunTime
{
	public static class NightPlacesData
	{
		public static List<NightPlaces> Places { get; private set; }

		static NightPlacesData()
		{
			var temp = new List<NightPlaces>();

			AddPlaces(temp);
		
			Places = temp.OrderBy(i => i.Name).ToList();
		}

		static void AddPlaces(List<NightPlaces> places)
		{
			places.Add(new NightPlaces()
				{
					Name      = "Thabo Mathuthu",
				    Location = "Quantity Surveyor",
					ImageUrl  = "images/kym-phillpotts.jpg",
					Biography = "Honours"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Bekezela Mathuthu",
				    Location = "Engineer",
					ImageUrl  = "images/glenn-stephens.jpg",
					Biography = "Artsan"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Nanzie Mpofu",
				    Location = "Tourism Management",
					ImageUrl  = "images/mark-smith.jpg",
					Biography = "General Degree"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Nobuhle Maseko",
				    Location = "Business",
					ImageUrl  = "images/jason-deboever.png",
					Biography = "Business Woman"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Thabiso Mathuthu",
				    Location = "Student",
					ImageUrl  = "images/jesse-dietrichson.jpg",
					Biography = "Student"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Hlosani Mpofu",
				     Location = "Msc Physicist",
					ImageUrl  = "images/judy-mcneil.png",
					Biography = "Material Scientist"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Ncekuenhle Mpofu",
				    Location = "Student",
					ImageUrl  = "images/michael-stonis.jpg",
					Biography = "Student"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Thembinkosi Nyoni",
				    Location = "Student",
					ImageUrl  = "images/rene-ruppert.jpg",
					Biography = "Student"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Patricia Foster",
				    Location = "Business Man",
					ImageUrl  = "images/Monateng/Patricia.jpg",
					Biography = "Ex Millitary"
				});

			places.Add(new NightPlaces()
				{
					Name      = "Sibusisiwe Mpofu",
				    Location = "Business Woman",
					ImageUrl  = "images/roger-petets.jpg",
					Biography = "Knitter"
				});

		}
	}
}