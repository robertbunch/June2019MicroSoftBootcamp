# This is a procedural appraoch to a text based rpg game
# The hero is fighting a goblin
# He has the option to:

# 1. fight
# 2. do nothing (goblin will still attack)
# 3. run

def main():
	hero_health = 10
	hero_power = 5
	goblin_health = 6
	goblin_power = 2

	# Run game as long as BOTH cahracters have health
	while goblin_health > 0 and hero_health > 0:
 		print "You have %d health and %d power." % (hero_health, hero_power)
 		print "The goblin has %d health and %d power." % (goblin_health, goblin_power)
 		print "What do you want to do?"
 		print "1. fight goblin"
 		print "2. do nothing"
 		print "3. flee"
 		print "> ",
 		user_input = raw_input()

 		if user_input == "1":
 			# Hero is goign to attack
 			goblin_health -= hero_power
 			print "You have done %d damage to the goblin" % hero_power
 			if goblin_health <= 0:
 				print "You have defeated the goblin!"
 		elif user_input == "2":
 			# Hero is going to do nothing
 			pass
		elif user_input == "3":
			print "Goodbye, coward"
			break
		else:
			print "Invalid input %s" % user_input

		if goblin_health > 0:
			# hero has attacked (or not) AND goblin is still alive
			hero_health -= goblin_power
			print "The goblin hits you for %d damage" % goblin_power
			if hero_health <= 0:
				print "You have been killed by the goblin."

		if hero_health > 0 and hero_health < 5:
			print "You have gone into a rage. Your power has increased!"
			hero_power += 5

main()